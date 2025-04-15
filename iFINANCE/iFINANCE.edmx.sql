

------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [iFINANCE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AccountCategoryGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Groups] DROP CONSTRAINT [FK_AccountCategoryGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_GroupMasterAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MasterAccounts] DROP CONSTRAINT [FK_GroupMasterAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionLineMasterAccount]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionLines] DROP CONSTRAINT [FK_TransactionLineMasterAccount];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionLineMasterAccount1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionLines] DROP CONSTRAINT [FK_TransactionLineMasterAccount1];
GO
IF OBJECT_ID(N'[dbo].[FK_GroupGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Groups] DROP CONSTRAINT [FK_GroupGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionTransactionLine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransactionLines] DROP CONSTRAINT [FK_TransactionTransactionLine];
GO
IF OBJECT_ID(N'[dbo].[FK_NonAdminUserTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_NonAdminUserTransaction];
GO
IF OBJECT_ID(N'[dbo].[FK_NonAdminUserUserPassword]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NonAdminUsers] DROP CONSTRAINT [FK_NonAdminUserUserPassword];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministratorUserPassword]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Administrators] DROP CONSTRAINT [FK_AdministratorUserPassword];
GO
IF OBJECT_ID(N'[dbo].[FK_AdministratorNonAdminUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NonAdminUsers] DROP CONSTRAINT [FK_AdministratorNonAdminUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccountCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccountCategories];
GO
IF OBJECT_ID(N'[dbo].[Administrators]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administrators];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[MasterAccounts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MasterAccounts];
GO
IF OBJECT_ID(N'[dbo].[NonAdminUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NonAdminUsers];
GO
IF OBJECT_ID(N'[dbo].[TransactionLines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionLines];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO
IF OBJECT_ID(N'[dbo].[UserPasswords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserPasswords];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccountCategories'
CREATE TABLE [dbo].[AccountCategories] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NULL,
    [type] nvarchar(max)  NULL
);
GO

-- Creating table 'Administrators'
CREATE TABLE [dbo].[Administrators] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [dateHired] datetime  NULL,
    [dateFinished] datetime  NULL,
    [UserPassword_ID] int  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [AccountCategory_ID] int  NOT NULL,
    [parent_ID] int  NOT NULL
);
GO

-- Creating table 'MasterAccounts'
CREATE TABLE [dbo].[MasterAccounts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [openingAmount] float  NULL,
    [closingAmount] float  NULL,
    [Group_ID] int  NOT NULL
);
GO

-- Creating table 'NonAdminUsers'
CREATE TABLE [dbo].[NonAdminUsers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NULL,
    [email] nvarchar(max)  NULL,
    [UserPassword_ID] int  NOT NULL,
    [Administrator_ID] int  NOT NULL
);
GO

-- Creating table 'TransactionLines'
CREATE TABLE [dbo].[TransactionLines] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [creditedAmount] float  NOT NULL,
    [debitedAmount] float  NOT NULL,
    [comment] nvarchar(max)  NULL,
    [MasterAccounts_ID] int  NOT NULL,
    [MasterAccounts1_ID] int  NOT NULL,
    [Transaction_ID] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [date] datetime  NOT NULL,
    [description] nvarchar(max)  NULL,
    [NonAdminUser_ID] int  NOT NULL
);
GO

-- Creating table 'UserPasswords'
CREATE TABLE [dbo].[UserPasswords] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [userName] nvarchar(max)  NOT NULL,
    [encryptedPassword] nvarchar(max)  NOT NULL,
    [passwordExpiryTime] int  NULL,
    [userAccountExpiryDate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'AccountCategories'
ALTER TABLE [dbo].[AccountCategories]
ADD CONSTRAINT [PK_AccountCategories]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Administrators'
ALTER TABLE [dbo].[Administrators]
ADD CONSTRAINT [PK_Administrators]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MasterAccounts'
ALTER TABLE [dbo].[MasterAccounts]
ADD CONSTRAINT [PK_MasterAccounts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'NonAdminUsers'
ALTER TABLE [dbo].[NonAdminUsers]
ADD CONSTRAINT [PK_NonAdminUsers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TransactionLines'
ALTER TABLE [dbo].[TransactionLines]
ADD CONSTRAINT [PK_TransactionLines]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'UserPasswords'
ALTER TABLE [dbo].[UserPasswords]
ADD CONSTRAINT [PK_UserPasswords]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccountCategory_ID] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [FK_AccountCategoryGroup]
    FOREIGN KEY ([AccountCategory_ID])
    REFERENCES [dbo].[AccountCategories]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AccountCategoryGroup'
CREATE INDEX [IX_FK_AccountCategoryGroup]
ON [dbo].[Groups]
    ([AccountCategory_ID]);
GO

-- Creating foreign key on [Group_ID] in table 'MasterAccounts'
ALTER TABLE [dbo].[MasterAccounts]
ADD CONSTRAINT [FK_GroupMasterAccount]
    FOREIGN KEY ([Group_ID])
    REFERENCES [dbo].[Groups]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GroupMasterAccount'
CREATE INDEX [IX_FK_GroupMasterAccount]
ON [dbo].[MasterAccounts]
    ([Group_ID]);
GO

-- Creating foreign key on [MasterAccounts_ID] in table 'TransactionLines'
ALTER TABLE [dbo].[TransactionLines]
ADD CONSTRAINT [FK_TransactionLineMasterAccount]
    FOREIGN KEY ([MasterAccounts_ID])
    REFERENCES [dbo].[MasterAccounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionLineMasterAccount'
CREATE INDEX [IX_FK_TransactionLineMasterAccount]
ON [dbo].[TransactionLines]
    ([MasterAccounts_ID]);
GO

-- Creating foreign key on [MasterAccounts1_ID] in table 'TransactionLines'
ALTER TABLE [dbo].[TransactionLines]
ADD CONSTRAINT [FK_TransactionLineMasterAccount1]
    FOREIGN KEY ([MasterAccounts1_ID])
    REFERENCES [dbo].[MasterAccounts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionLineMasterAccount1'
CREATE INDEX [IX_FK_TransactionLineMasterAccount1]
ON [dbo].[TransactionLines]
    ([MasterAccounts1_ID]);
GO

-- Creating foreign key on [parent_ID] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [FK_GroupGroup]
    FOREIGN KEY ([parent_ID])
    REFERENCES [dbo].[Groups]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GroupGroup'
CREATE INDEX [IX_FK_GroupGroup]
ON [dbo].[Groups]
    ([parent_ID]);
GO

-- Creating foreign key on [Transaction_ID] in table 'TransactionLines'
ALTER TABLE [dbo].[TransactionLines]
ADD CONSTRAINT [FK_TransactionTransactionLine]
    FOREIGN KEY ([Transaction_ID])
    REFERENCES [dbo].[Transactions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionTransactionLine'
CREATE INDEX [IX_FK_TransactionTransactionLine]
ON [dbo].[TransactionLines]
    ([Transaction_ID]);
GO

-- Creating foreign key on [NonAdminUser_ID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_NonAdminUserTransaction]
    FOREIGN KEY ([NonAdminUser_ID])
    REFERENCES [dbo].[NonAdminUsers]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NonAdminUserTransaction'
CREATE INDEX [IX_FK_NonAdminUserTransaction]
ON [dbo].[Transactions]
    ([NonAdminUser_ID]);
GO

-- Creating foreign key on [UserPassword_ID] in table 'NonAdminUsers'
ALTER TABLE [dbo].[NonAdminUsers]
ADD CONSTRAINT [FK_NonAdminUserUserPassword]
    FOREIGN KEY ([UserPassword_ID])
    REFERENCES [dbo].[UserPasswords]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NonAdminUserUserPassword'
CREATE INDEX [IX_FK_NonAdminUserUserPassword]
ON [dbo].[NonAdminUsers]
    ([UserPassword_ID]);
GO

-- Creating foreign key on [UserPassword_ID] in table 'Administrators'
ALTER TABLE [dbo].[Administrators]
ADD CONSTRAINT [FK_AdministratorUserPassword]
    FOREIGN KEY ([UserPassword_ID])
    REFERENCES [dbo].[UserPasswords]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorUserPassword'
CREATE INDEX [IX_FK_AdministratorUserPassword]
ON [dbo].[Administrators]
    ([UserPassword_ID]);
GO

-- Creating foreign key on [Administrator_ID] in table 'NonAdminUsers'
ALTER TABLE [dbo].[NonAdminUsers]
ADD CONSTRAINT [FK_AdministratorNonAdminUser]
    FOREIGN KEY ([Administrator_ID])
    REFERENCES [dbo].[Administrators]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdministratorNonAdminUser'
CREATE INDEX [IX_FK_AdministratorNonAdminUser]
ON [dbo].[NonAdminUsers]
    ([Administrator_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------