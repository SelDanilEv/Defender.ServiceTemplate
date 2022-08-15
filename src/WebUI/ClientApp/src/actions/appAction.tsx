export function updateLanguage(payload) {
    return dispath => {
        dispath({
            type: "UPDATE_LANGUAGE",
            payload: payload
        });
    }
}