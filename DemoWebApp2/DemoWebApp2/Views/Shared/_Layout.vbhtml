﻿<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - マイ ASP.NET アプリケーション</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @RenderSection("styles", required:=False)

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("アプリケーション名", "Index", "Home", New With { .area = "" }, New With { .class = "navbar-brand" })
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("ホーム", "Index", "Home")</li>
                    <li>@Html.ActionLink("詳細", "About", "Home")</li>
                    <li>@Html.ActionLink("問い合わせ", "Contact", "Home")</li>
                    <li>@Html.ActionLink("Employee", "Index", "Employee")</li>
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Master Data <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Branch", "Index", "Branch")</li>
                            <li>@Html.ActionLink("Job Title", "Index", "JobTitle")</li>
                            <li>@Html.ActionLink("Department", "Index", "Department")</li>
                            <li role="separator" class="divider"></li>
                            <li>@Html.ActionLink("Project", "Index", "Project")</li>
                            <li role="separator" class="divider"></li>
                            <li>@Html.ActionLink("Project Assigned", "Index", "ProjectEmployee")</li>
                        </ul>
                    </li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - マイ ASP.NET アプリケーション</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
