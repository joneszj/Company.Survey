// step
function updateStep(body) {
    return fetch(`${window.location.origin}/step/Update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function addStep(body) {
    return fetch(`${window.location.origin}/step/Add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function removeStepConfirm(id) {
    if (confirm("Removing the step will remove all questions in the step. Continue?")) {
        return fetch(`${window.location.origin}/step/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: JSON.stringify({ StepId: Number(id) })
        }).then(e => assertStatus(e));
    }
}

// step content
function updateStepContent(body) {
    return fetch(`${window.location.origin}/stepcontent/Update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function addStepContent(body) {
    return fetch(`${window.location.origin}/stepcontent/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function removeStepContentConfirm(id) {
    if (confirm("Removing the step content will remove all content blocks in the step. Continue?")) {
        return fetch(`${window.location.origin}/stepcontent/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: JSON.stringify({ StepContentId: Number(id) })
        }).then(e => assertStatus(e));
    }
}

// content block
function updateContentBlock(body) {
    return fetch(`${window.location.origin}/contentblock/update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function addContentBlock(body) {
    return fetch(`${window.location.origin}/contentblock/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function removeContentBlock(id) {
    if (confirm("Are you sure?")) {
        return fetch(`${window.location.origin}/contentblock/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: JSON.stringify({ ContentBlockId: Number(id) })
        }).then(e => assertStatus(e));
    }
}

// question
function updateQuestion(body) {
    return fetch(`${window.location.origin}/question/update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function updateQuestionText(body) {
    return fetch(`${window.location.origin}/question/updatetext`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function updateQuestionNote(body) {
    return fetch(`${window.location.origin}/question/updatenote`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function updateQuestionNote(body) {
    return fetch(`${window.location.origin}/question/updateorder`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function addQuestion(body) {
    return fetch(`${window.location.origin}/question/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify(body)
    }).then(e => assertStatus(e));
}

function removeQuestion(id) {
    if (confirm("Are you sure?")) {
        return fetch(`${window.location.origin}/question/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: JSON.stringify({ QuestionId: Number(id) })
        }).then(e => assertStatus(e));
    }
}

// notifications
function assertStatus(response) {
    return new Promise(resolve => {
        if (response.ok) $.notify('Success!', "success");
        else $.notify('Something when wrong :(', "error");
        resolve(response);
    })
}