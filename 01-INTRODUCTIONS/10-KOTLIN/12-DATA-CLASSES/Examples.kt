fun main() {
    data class User(val name:String,val age:Int)
    val a=User("Peyman",20)
    println(a.copy(age=21))
}
