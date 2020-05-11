import React,{Component} from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component{
state={
  orderForm:{

        name:{
                  elementType="input",
                  elementConfig:{
                  type:"text",
                  placeholder:"enter your name"
                  },
                  value: '',
                  validation:{
                  required:true
                  },
                  valid: false
              },


        email:{
                  elementType="input",
                  elementConfig:{
                  type:"email",
                  placeholder:"enter your mail id"
                  },
                  value: '',
                  valid: false,
                  validation:{
                  required:true
                  }
              },

          
          phone:{
                  elementType="input",
                  elementConfig:{
                  type:"text",
                  placeholder:"enter your mobile number"
                  },
                  value: '',
                  valid: false,
                  validation:{
                    required:true
                  }
              },  

          
          Country:{
                  elementType="select",
                  elementConfig:{
                  options:[
                      {value:"India", displayValue:"India"},
                      {value:"America", displayValue:"America"},
                      {value:"Australia", displayValue:"Australia"},
                      {value:"Nepal", displayValue:"Nepal"},
                      {value:"Sri Lanka", displayValue:"Sri Lanka"}
                  ]
                },
                  value: '',
                  valid: false,
                  validation:{
                    required:true
                  }

              }
        },
}

checkValidity(value, rules) {
  let isValid = true;
  if (!rules) {
      return true;
  }
  
  if (rules.required) {
      isValid = value.trim() !== '' && isValid;
  }

  if (rules.minLength) {
      isValid = value.length >= rules.minLength && isValid
  }

  if (rules.maxLength) {
      isValid = value.length <= rules.maxLength && isValid
  }

  if (rules.isEmail) {
      const pattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;
      isValid = pattern.test(value) && isValid
  }

  if (rules.isNumeric) {
      const pattern = /^\d+$/;
      isValid = pattern.test(value) && isValid
  }

  return isValid;
}

inputChangeHandler=(event,inputIdentifier)=>{

          const updatedOrderForm={
              ...this.state.orderForm
          };

          const updatedFormElement={
              ...updatedOrderForm[inputIdentifier]
          };

          updatedFormElement.value=event.target.value;
          updatedFormElement.valid = this.checkValidity(updatedFormElement.value, updatedFormElement.validation);
          //updatedFormElement.touched = true;
          updatedOrderForm[inputIdentifier] = updatedFormElement;

          let formIsValid=true;
          for(let inputIdentifier in updatedOrderForm)
          {
            formIsValid = updatedOrderForm[inputIdentifier].valid && formIsValid;

          }


          this.setState({orderForm: updatedOrderForm, formIsValid: formIsValid});
}
  render()
  {
    let formElementsArray=[];
    for(let key in this.state.orderForm)
    {
        formElementsArray.push({
          id:key,
          config:this.state.orderForm[key]
        });
    }

    let form=(
        <form>
          {formElementsArray.map(formElement=>(
            <Input>
              key={formElement.id}
              elementType={formElement.config.elementType}
              elementConfig={formElement.config.elementConfig}
              value={formElement.config.value}
              changed={()=>this.inputChangeHandler(event,formElement.id)}
            </Input>

          ))}
          <button>Submit</button>
        </form>
        
    );
    return(

      <div>
        
          <h3>Form validation practice</h3>
          <hr/>
          {form} 
      </div>
    );
  }
}

export default App;
