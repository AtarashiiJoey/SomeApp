
// Immediately invoked function expression
(function () {
    $.connection.hub.start()
        .done(function () {
            console.log("Working");
            $.connection.templateHub.server.announce("connected");
        })  // if works
        .fail(function () { alert("Failed") }); // if fails

    $.connection.templateHub.client.announce = function (message) {
        $("#welcome-messages").append(message + "<br/>");
    };
})()