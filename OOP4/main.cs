using System;

namespace OOP4
{
    internal class main
    {
        static void Main(string[] args)
        {
            #region Q1
            //c) To declare abstract methods and properties
            #endregion
            #region Q2
            //a) private
            #endregion
            #region Q3
            //b) No
            #endregion
            #region Q4
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion
            #region Q5
            //d) implements
            #endregion
            #region Q6
            //a) Yes
            #endregion
            #region Q7
            //b) No, all members are implicitly public
            #endregion
            #region Q8
            //a) To hide the interface members from outside access
            #endregion
            #region Q9
            //No, interfaces cannot have constructors
            #endregion
            #region Q10
            //c) By separating interface names with commas
            #endregion
            //part2
            #region Q1
            Circle circle = new Circle { Radius = 5};
            circle.DisplayShapeInfo();
            Rectangle rectangle = new Rectangle { Length = 4, Width =6};
            rectangle.DisplayShapeInfo();
            #endregion
            #region Q2
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "Ahmed";
            string password = "123";

            bool isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"User {username} authenticated? {isAuthenticated}");

            if (isAuthenticated)
            {
                bool isAuthorized = authService.AuthorizeUser(username, "Admin");
                Console.WriteLine($"User {username} authorized as Admin? {isAuthorized}");
            }
            #endregion
            #region Q3
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "Ahmed";
            string message = "Your order has been shipped";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);
            #endregion
        }
    }
}
