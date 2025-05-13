DROP TABLE users, user_information, user_financial_profile;
DROP TABLE family,family_members;
DROP TABLE card, creditCard;
DROP TABLE bankInstruction, debitCard;
DROP TABLE investments, investmentTransaction, pensionInvestment, equityInvestment, mutualFundInvestment, fixedDepositInvestment, realEstateInvestment, metalInvestment , insuranceInvestment;
DROP TABLE expenses, recurringExpense, expenseSplit, bill;
DROP TABLE tags;



CREATE TABLE users(
	id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	userName NVARCHAR(100) NOT NULL,
	firstName NVARCHAR(50),
	middleName NVARCHAR(50),
	lastName NVARCHAR(50),
	jod Date,
	dob Date,
	email NVARCHAR(100),
	mobile NVARCHAR(15),
	gender CHAR(1),
	password VARCHAR(60)
);

CREATE TABLE user_information(
	id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	pan CHAR(10),
	aadhar CHAR(12),
	addressLine_1 NVARCHAR(255),
	addressLine_2 NVARCHAR(255),
	city NVARCHAR(50),
	country NVARCHAR(50),
	pincode VARCHAR(12)
);

CREATE TABLE user_financial_profile(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    annualIncome DECIMAL(18,2), -- in LPA
    title NVARCHAR(100),
    emplpoyer NVARCHAR(100),
    investmentGoal NVARCHAR(255)
);

CREATE TABLE family(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    name NVARCHAR(100),
    rod DATE,
    description NVARCHAR(255),
    headId UNIQUEIDENTIFIER,
    salt NVARCHAR(100)
);
CREATE TABLE family_members(
    id int PRIMARY KEY IDENTITY(1,1),
    familyId UNIQUEIDENTIFIER,
    memberId UNIQUEIDENTIFIER,
    role NVARCHAR(50)
);


CREATE TABLE card(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    userId UNIQUEIDENTIFIER,
    cardName NVARCHAR(100),
    nameOnCard NVARCHAR(100),
    cardNumer CHAR(16),
    expiry DATE,
    network NVARCHAR(50),
    status BIT,
    cardType CHAR(1)
);

CREATE TABLE creditCard(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    creditLimit DECIMAL(18,2),
    interest DECIMAL(5,2),
    billingDate DATE,
    dueDate DATE,
    gracePeriod INT

);

CREATE TABLE bankInstruction(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    accountNumber VARCHAR(18),
    userId UNIQUEIDENTIFIER,
    accountType CHAR(1),
    description NVARCHAR(255),
    bankName NVARCHAR(100),
    branch NVARCHAR(100),
    ifsc CHAR(11),
    isPrimary BIT
);
CREATE TABLE debitCard(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    instructionId UNIQUEIDENTIFIER,
    dailyLimit DECIMAL(18,2),
    atmLimit DECIMAL(18,2),

);

-- TODO: add Investment and their classes
CREATE TABLE investments(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    userId UNIQUEIDENTIFIER,
    name NVARCHAR(100),
    nominee UNIQUEIDENTIFIER ,
    description NVARCHAR(255),
    startedOn DATE,
    isPeriodic BIT,
    frequency INT,
    investmentType CHAR(1)
);

CREATE TABLE investmentTransaction(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    investmentId UNIQUEIDENTIFIER,
    transactionDate DATE,
    amount DECIMAL(18,2),
    units DECIMAL(18,4),
    unitPrice DECIMAL(18,4),
    notes NVARCHAR(255),
    paymentMode NVARCHAR(50),
    cardId UNIQUEIDENTIFIER,
    bankId UNIQUEIDENTIFIER,
);

CREATE TABLE pensionInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    currentValue DECIMAL(18,2),
    instructionId UNIQUEIDENTIFIER,
    pensionType NVARCHAR(100),
    pran NVARCHAR(20),
    uan NVARCHAR(20),
    tier NVARCHAR(10),
    monthlyContribution DECIMAL(18,2),
    employerContribution DECIMAL(18,2),
    lockedInPeriod INT,
);

CREATE TABLE equityInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    stockSymbol NVARCHAR(10),
    exchange NVARCHAR(50),
    sector NVARCHAR(100),
    brokerage NVARCHAR(100)
);

CREATE TABLE mutualFundInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    fundName NVARCHAR(100),
    fundType NVARCHAR(50),
    folioNumber NVARCHAR(30),
    amcFirm VARCHAR(100),
    registrar NVARCHAR(50),
    modeOfInvestment NVARCHAR(50)
);

CREATE TABLE fixedDepositInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    instructionID UNIQUEIDENTIFIER,
    interestRate DECIMAL(5,2),
    maturityDate Date,
    principalAmount DECIMAL(18,2),
    maturityAmount DECIMAL(18,2),
    autoRenewal BIT,
    compounded BIT,
);

CREATE TABLE realEstateInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    location NVARCHAR(255),
    propertyType NVARCHAR(20),
    estimatedValue DECIMAL(18,2),
    isRented BIT,
    rent DECIMAL(18,2),
    renatalAgreementstartedOn Date,
    renatalAgreementExpiresOn Date,
    areaInsft DECIMAL(18,2)
);

CREATE TABLE metalInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    metalType NVARCHAR(50),
    weightInGms DECIMAL(18,2),
    pricePerGm DECIMAL(18,2),
    makingCharges DECIMAL(18,2),
    seller NVARCHAR(100),
    invoiceNumber NVARCHAR(30),
    Purity DECIMAL(5, 2) NULL
);

CREATE TABLE insuranceInvestment(
    id UNIQUEIDENTIFIER PRIMARY KEY,
    policyNumber NVARCHAR(30),
    policyType NVARCHAR(30),
    sumAssured DECIMAL(18,2),
    insurerName NVARCHAR(100),
    policyEndDate DATE,
    isTaxSaving BIT
);

CREATE TABLE expenses(
    ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    userId UNIQUEIDENTIFIER,
    description NVARCHAR(255),
    amount DECIMAL(18,2),
    expenseDate DATE,
    category NVARCHAR(50),
    paymentMode NVARCHAR(50),
    cardId UNIQUEIDENTIFIER,
    bankId UNIQUEIDENTIFIER,
    isRecurring BIT,
    expenseType NVARCHAR(50) -- like normal expense or a speciifc bill
);
CREATE TABLE recurringExpense(
    ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    startDate DATE,
    frequency INT,
    nextDate DATE,
    lastDate DATE,
    isAutoPaid BIT
);
CREATE TABLE Bill (
    ExpenseId UNIQUEIDENTIFIER PRIMARY KEY,  -- FK to Expense(Id)
    BillerName NVARCHAR(100),
    BillNumber NVARCHAR(50),
    DueDate DATE NOT NULL,
    LateFeeApplicable BIT DEFAULT 0,
);

CREATE TABLE expenseSplit(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    expenseId UNIQUEIDENTIFIER,
    userId UNIQUEIDENTIFIER,
    shareAmount DECIMAL(18,2),
    paidOn DATE,
    isPaid BIT
);

CREATE TABLE tags(
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    tag NVARCHAR(50),
    value NVARCHAR(50),
    tagType NVARCHAR(50)
);