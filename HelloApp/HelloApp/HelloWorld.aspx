<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="HelloApp.HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hello World App- A Single Page App consuming a WebAPI</title>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.7/angular.min.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script>
        // setting up the angularjs module/app and controller
        angular.module('HelloWorldApp', [])
            .controller('HelloWorldController', function ($scope, $http) {
                // call the web api to get the data 
                var uri = "api/helloworld/gethelloworld";
                $http.get(uri)
                    .then(function (response) {
                        //assign it to scope variable for the page to access and use it to show the data 
                        $scope.helloWorldData = response.data.Data;
                    });
            });
    </script>
    <style>
        body {
            font-family: Helvetica, Arial, Sans-Serif, Verdana;
            font-size: 12px;
        }
        
        table {
            width: auto;
            float: left;
            border-spacing: 1;
            align-content: center;
        }

        #tblMain td, #tblMain th {
            border: 1px solid #CCC;
            height: 25px;
            width: auto;
            text-align: left;
        }

        #tblMain th {
            background: silver;
        }

        #tblMain td {
            background: whitesmoke;
        }
    </style>
</head>
<body>
    <body ng-app="HelloWorldApp">
        <div ng-controller="HelloWorldController">
            <table id="tblMain">
                <tr>
                    <th>Hello World App- A Single Page App consuming a WebAPI</th>
                </tr>
                <tr>
                    <td><strong>Data returned from HelloWorld API Call :</strong> {{helloWorldData}}</td>
                </tr>
            </table>
        </div>
    </body>
</html>
