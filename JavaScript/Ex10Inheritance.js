// const baseClass = function(){
        //     this.someFunc = function(){
        //         alert("someFunc of the abs class")
        //     }
        // }
        // const DerivedClass = function(){
        //    this.__proto__ = BaseClass
        //     this.DerivedClass = ()=> alert("derived Func of the derived class")
        // }
        // const obj = new baseClass()
        // obj.someFunc()

        class BaseClass {
            someFunc(){
                alert("someFunc is called")
            }
        }
        class DerivedClass extends BaseClass {
            DerivedFunc(){
                alert("derived Func is called")
            }
        }
        const obj = new DerivedClass()
        obj.DerivedFunc()