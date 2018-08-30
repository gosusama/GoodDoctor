export class UserModel{
    public UserName : string;
    public Password : string;
    constructor( user : string , pass : string){
        this.UserName = user;
        this.Password = pass;
    }
}