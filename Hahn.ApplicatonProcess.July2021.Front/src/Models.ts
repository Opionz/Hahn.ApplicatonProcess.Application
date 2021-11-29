  export interface User{
  
        Age :number;
        FirstName :string;
        LastName :string;
        Email:string;
        Address :Address;
        Assets : Asset

}

export interface Address{
  
   
        City :string
        Street :string
        HouseNumber :string
        PostalCode :string
}

export interface Asset{
    Id :string;
 Name:string;
 Symbol:string;
}