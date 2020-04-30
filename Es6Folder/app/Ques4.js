//Extract all keys inside address object from user object using destructuring ?


const user = {
    firstName: 'Sahil',
    lastName: 'Dua',
    Address: {
    Line1: 'address line 1',
    Line2: 'address line 2',
    State: 'Delhi',
    Pin: 110085,
    Country: 'India',
    City: 'New Delhi',
    },
    phoneNo: 9999999999
    }

    //here i did the destructuring and renamed the key values
    let{firstName:fname,lastName:lname,Address:add,phoneNo:mobile}=user;
    console.log('Question4\n\n');

    console.log(` 
    FirstName:${fname}
    LastName:${lname}
    Address:
    ${add.Line1}
    ${add.Line2}
    ${add.State}
    ${add.Pin}
    ${add.Country}
    ${add.City}
    Phone:${mobile}`);

    export default user;