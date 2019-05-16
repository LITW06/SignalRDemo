$(() => {
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/chatHub").build();

    connection.start().then(() => {
        connection.invoke("NewUser");
    });

    $("#send").on('click', () => {
        const name = $("#name").val();
        const message = $("#message").val();
        connection.invoke("SendMessage", { name, message });
    });

    connection.on("NewMessage", chatMessage => {
        $("#messages").append(`<h4>${chatMessage.name} says: ${chatMessage.message}</h4>`)
    });

    connection.on("NewCount", count => {
        $("#count").text(count.count);
    });
});