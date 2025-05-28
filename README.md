# OneWealth

A single platform for your wealth

## Validations in place

| **Object** | **Field**    | **Validation Type** | **Constraints / Details**                                                        |
| ---------- | ------------ | ------------------- | -------------------------------------------------------------------------------- |
| User       | UserName     | Required            | Not null, not empty                                                              |
|            |              | Length              | Min 3, Max 100 characters                                                        |
|            |              | Format              | Alphanumeric, ., _ only — must not start/end with . or _; no consecutive . or \_ |
| User       | FirstName    | Required            | Not null                                                                         |
|            |              | Length              | Max 100 characters                                                               |
|            |              | Format              | Letters only: `^[a-zA-Z]+$`                                                      |
| User       | LastName     | Required            | Not null                                                                         |
|            |              | Length              | Max 100 characters                                                               |
|            |              | Format              | Letters only: `^[a-zA-Z]+$`                                                      |
| User       | MiddleName   | Optional            | Max 100 characters                                                               |
| User       | Gender       | Required            | Not null                                                                         |
|            |              | Enum Check          | Must be a valid enum value                                                       |
| User       | DateOfBirth  | Required            | Not null                                                                         |
|            |              | Custom Rule         | Must be in the past (not a future date)                                          |
| User       | Email        | Required            | Not null                                                                         |
|            |              | Format              | Must be a valid email                                                            |
| User       | Mobile       | Required            | Not null                                                                         |
|            |              | Format              | Digits only; length 10–15: `^[0-9]{10,15}$`                                      |
| User       | Address      | Required            | Not null; validated using `AddressValidator`                                     |
| User       | PAN          | Required            | Not null, not empty                                                              |
|            |              | Format              | Alphanumeric only: `^[a-zA-Z0-9]+$`                                              |
|            |              | Length              | Max 10 characters                                                                |
| User       | Aadhar       | Required            | Not null, not empty                                                              |
|            |              | Format              | Alphanumeric only: `^[a-zA-Z0-9]+$`                                              |
|            |              | Length              | Max 15 characters                                                                |
| Address    | AddressLine1 | Required            | Not null, not empty                                                              |
|            |              | Length              | Max 255 characters                                                               |
| Address    | AddressLine2 | Optional            | Max 255 characters                                                               |
| Address    | City         | Required            | Not null, not empty, max 255 characters                                          |
| Address    | Country      | Required            | Not null, not empty, max 255 characters                                          |
| Address    | Pincode      | Required            | Not null, not empty, max 255 characters                                          |
