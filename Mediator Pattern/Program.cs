var chatRoom = new ChatRoom();

var user1 = new User("Ahmed", chatRoom);
var user2 = new User("Ali", chatRoom);
var user3 = new User("Nassar", chatRoom);

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);
chatRoom.RegisterUser(user3);

user1.Send("Hello every one ,Welcome in my group");
