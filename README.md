# Form-Structures
This project was built with C# MVC architecture.

Features:

1- ViewBag ==> is a single-use dynamic type temporary variable store. It is the slowest. It is often used in notification pop-ups. Cannot be used with 'foreach'.

2- ViewData ==> is a single-use dictionary-type temporary variable store, faster and safer than 'ViewBag', and contains the variables used to avoid confusion with 'Model'.

3- TempData ==> is a single-use dictionary-type temporary variable store. It is the fastest of them all. It is used to store form values received from the user.

**These structures provide the communication between 'backend' and 'frontend'. Also 'Ajax' can be used for this. But 'Javascript' is required for this.

You can also check out the Http methods in : https://mbilgil0.medium.com/http-metotlar%C4%B1-http-request-methods-90d57d574dfa
