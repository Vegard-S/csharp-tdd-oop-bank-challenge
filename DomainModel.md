| Classes        | Methods                           | Scenario                                                  | Output  |
|----------------|-----------------------------------|-----------------------------------------------------------|---------|
| Core           |                                   |                                                           |         |
| Accounts       | GenerateBankStatement()           | generate bank statement for an account                    | string  |
| Accounts       | DepositFunds(decimal ammount)     | Deposit funds into account                                | bool    |
| Accounts       | WithdrawFunds(decimal ammount)    | Withdraw funds from and account, currentAccount overrides | bool    |
| Extensions     |                                   |                                                           |         |
| Accounts       | CalculateBalance()                | calculate the balance using transaction history           | decimal |
| CurrentAccount | RequestOverdraft(decimal ammount) | request an overdraft for the account                      | bool    |
| CurrentAccount | OverdraftResponse(bool answer)    | approve and reject an overdraft                           | bool    |
| Accounts       | SendSMS()                         | send an sms of the bank statement                         | sms?    |