//<reference types='cypress' />;

describe('Initial Test', () => {
  it('should visit the sign up page', () => {
    cy.visit('http://localhost:3000/');
  });

  beforeEach(() => {
    cy.visit('http://localhost:3000/');
  });

  it('should contain sign up, if it is login page route it to sign up page', () => {
    //cy.visit('http://localhost:3000/');

    /*
    if (cy.get("h1").contains("Sign Up")) {
      cy.get('button').contains('Sign Up').click();
    } else {
      cy.get('button').contains('Login').click();
    }*/
    cy.get('h1').then((h1) => {
      if (h1.find('Sign Up')) cy.get('button').contains('Sign Up').click();
      else cy.get('button').contains('Login').click();
    });
  });

  it('should input details,submit it and route to home page', () => {
    cy.get('h1').then((h1) => {
      if (h1.find('Sign Up')) cy.get('button').contains('Sign Up').click();
      else cy.get('button').contains('Login').click();
    });

    cy.get('input[type="email"]').type('posum@gmail.com');
    cy.get('input[type="text"]').type('HungryPosum');
    cy.get('input[type="password"]').type('Thunderbird@123');
    cy.get('button').contains('Sign Up').click();

    cy.url().should('include', '/');
  });

  /*
  it('calculator ', () => {
    cy.visit('http://localhost:3000/Calculator');

    cy.get('');
  });
  */
});
