// step
function updateStep() {
    fetch(`${window.location.origin}/step/Update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: JSON.stringify({
            Id: Number(event.target.id),
            Order: Number(event.target.dataset.order),
            Title: event.target.value
        })
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

function removeStepConfirm(id, cb) {
    if (confirm("Removing the step will remove all questions in the step. Continue?")) {
        return fetch(`${window.location.origin}/step/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: JSON.stringify({ StepId: Number(id) })
        }).then(e => assertStatus(e)).then(cb);
    }
}

// step content
function updateStepContent() {
    fetch(`${window.location.origin}/stepcontent/Update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function addStepContent() {
    fetch(`${window.location.origin}/stepcontent/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function removeStepContentConfirm() {
    if (confirm("Removing the step content will remove all content blocks in the step. Continue?")) {
        fetch(`${window.location.origin}/stepcontent/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: null
        }).then(e => assertStatus(e));
    }
}

// content block
function updateContentBlock() {
    fetch(`${window.location.origin}/stepblock/update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function addContentBlock() {
    fetch(`${window.location.origin}/stepblock/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function removeContentBlock() {
    if (confirm("Are you sure?")) {
        fetch(`${window.location.origin}/contentblock/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: null
        }).then(e => assertStatus(e));
    }
}

// question
function updateQuestion() {
    fetch(`${window.location.origin}/question/update`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function addQuestion() {
    fetch(`${window.location.origin}/question/add`, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        credentials: "same-origin",
        body: null
    }).then(e => assertStatus(e));
}

function removeQuestion() {
    if (confirm("Are you sure?")) {
        fetch(`${window.location.origin}/question/remove`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' },
            credentials: "same-origin",
            body: null
        }).then(e => assertStatus(e));
    }
}

function assertStatus(response) {
    return new Promise(resolve => {
        if (response.ok) console.assert(response, "TODO: add success indication");
        else console.assert(response, "TODO: add failure indication")
        resolve(response);
    })
}