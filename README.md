# kurakaniapp_socket

Kurakani means Chatting! So, this is a chat application. The server side has been built in JAVA eclipse and the client has been built with an asynchronous socket, so execution of the client application is not suspended while the server returns a response.

  The Socket and ServerSocket classes from the java.net package have been used to implement client-server communication. A ServerSocket has been instantiated with a designated port 4321. A new Socket is then created to accept the ServerSocket's connection request by calling the accept() method on the ServerSocket object.

  In the server side, the InputStreamReader, BufferedReader, and OutputStreamWriter and BufferedWriter class objects have been instantiated to retrieve input from the client and to send output to the client, via methods getInputStream and getOutputStream respectively. 

The four maps have been created in server side to store the username, roomnumber and chat messages. They are 
  clientSocketUserMap (<userName> <clientSocket>), 
  messageChatRoomMap (<ChatRoom> <message>), 
  chatRoomUserMap (<userName> <chatRoom>) and 
  timeChatRoomMap (<Chatroom> <time>) 
  
  Each connected client is given a separate thread. Since server is locally hosted, first the client establishes the remote endpoint for the socket and then creates the TCP/IP socket. Then it invokes receive method. 
  
  The receive method on the client sets up the state object and then calls the BeginReceive method to read the data from the client socket asynchronously. The ReceiveCallback method then implements the AsyncCallback delegate. It receives the data from the network device and builds a message string. It reads one or more bytes of data from the network into the data buffer and then calls the BeginReceive method again until the data sent by the client is complete.
  
  The user can provide the username and can choose any room out of 20 listed rooms and fetch the previously stored chat history, and start chatting as shown below. Clicking the send button sends the encoded message containing the logged in username, chatroom and the message from the chat textbox via socket by implementing the Encoding.GetBytes method that expects discrete conversions and it handles multiple conversions on a single input stream.
  
  The client can switch from one room to another and disconnect the chatroom anytime.
  
  When the room remains inactive for 7 days, then the messages stored in the room gets removed using epoch time concept from the time package to calculate the difference in the current time and the last time when the room was active.
  Since the message is stored in the map the server should be on all the time, and to test the mechanism of deleting messages after 7 days, test of static long type is assigned an initial value of 10 and used that value at the condition checking block in the program.
  
  
  
