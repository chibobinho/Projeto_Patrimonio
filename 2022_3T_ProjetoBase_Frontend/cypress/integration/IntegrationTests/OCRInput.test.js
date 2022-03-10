describe('Integração - OCR', ()=> {

    beforeEach(()=>{
        cy.visit('http://localhost:3000')
    })

    it('Deve logar e inserir a imagem OCR retornando o valor correto da mesma', ()=> {
        cy.get('.cabecalhoPrincipal-nav-login').should('exist')
        cy.get('.cabecalhoPrincipal-nav-login').click();

        cy.get('.input__login').first().type('paulo@email.com')
        cy.get('.input__login').last().type('123456789')

        cy.get('#btn__login').click();

        cy.get('.input[type-file]').first().selectFile('src/assets/tests/equipamento.jpeg')

        cy.wait(4000)

        cy.get('#codigoPatrimonio').should('have.value', '1202529')

        cy.get('.input__login').first().type('notebook do pai :D')

        cy.get('.btn').click();
    })
})