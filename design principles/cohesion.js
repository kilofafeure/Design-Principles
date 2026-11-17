// Baja cohesión: una clase reúne responsabilidades poco relacionadas entre sí.
class UserLowCohesion {

    createUser(){}

    getSales(){}

    sendEmail(){}

    exportPDF(){}
}

// Alta cohesión: una clase agrupa responsabilidades relacionadas y enfocadas en un único propósito.
class UserHighCohesion {

    create(){}

    update(){}

    delete(){}

    getById(id){}

}