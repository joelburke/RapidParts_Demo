@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>_master</title>
    <link href="@Url.Content("~/css/bootstrap.css")" rel="stylesheet" type="text/css" />
    <link href="@Url.Content("~/css/bootstrap-responsive.min.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/js/jquery-2.0.2.min.js")" type="text/javascript"></script>
</head>
<body>
    <div>
        @RenderBody()
    </div>
    <div class="navbar">
    <div class="navbar-inner">
        <div class="container">
            <button type="button" class="btn btn-navbar" 
                    data-toggle="collapse" data-target=".nav-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="brand" href="#">Euricom</a>
            <div class="nav-collapse">
                <ul class="nav">
                    <li class="active"><a href="#">GitHub</a></li>
                    <li><a href="#">Bootstrap</a></li>
                    <li><a href="#">MongoDB</a></li>
                    <li><a href="#">Knockout</a></li>
                    <li><a href="#">AppHarbor</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
    <script src="@Url.Content("~/js/bootstrap.min.js")" type="text/javascript"></script>
</body>
</html>
