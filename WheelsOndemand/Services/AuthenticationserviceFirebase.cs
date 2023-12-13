using WheelsOndemand.Models;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Configuration;

namespace WheelsOndemand.Services
{
    public class AuthenticationserviceFirebase
    {
        private static AuthenticationserviceFirebase _instance;
        public static AuthenticationserviceFirebase Instance => _instance ??= new AuthenticationserviceFirebase();

        private FirebaseAuthClient _client;

        private AuthenticationserviceFirebase()
        {
        }

        private void InitializeFirebase()
        {
            var config = new FirebaseAuthConfig
            {
               ApiKey = AppSettings.FirebaseApiKey,
                AuthDomain = AppSettings.FirebaseAuthDomain,
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            };

            _client = new FirebaseAuthClient(config);
        }

        public async Task<(bool success, string message)> SignInAsync(string email, string password)
        {
            InitializeFirebase();

            string message;
            var success = false;

            try
            {
                var userCredential = await _client.SignInWithEmailAndPasswordAsync(email, password);
                message = $"Signed in as {userCredential.User.Info.Email}";
                success = true;
            }
            catch (FirebaseAuthHttpException ex)
            {
                message = ex.Reason.ToString() == "Unknown" ? "Incorrect email or password." : ex.Reason.ToString();
            }
            catch (Exception ex)
            {
                message = $"An error occurred: {ex.Message}";
            }

            return (success, message);
        }

        public async Task<(bool success, string message)> SignUpAsync(string email, string password)
        {
            InitializeFirebase();
            string message;
            var success = false;

            try
            {
                var userCredential = await _client.CreateUserWithEmailAndPasswordAsync(email, password);
                message = $"Account created for {userCredential.User.Info.Email}";
                success = true;
            }
            catch (FirebaseAuthHttpException ex)
            {
                message = ex.Reason.ToString();
            }
            catch (Exception ex)
            {
                message = $"An error occurred: {ex.Message}";
            }

            return (success, message);
        }
    }
}
