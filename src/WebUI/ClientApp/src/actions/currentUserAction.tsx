export function updateUserInfo(payload) {
    return dispath => {
        dispath({
            type: "UPDATE_USER_INFO",
            payload: payload
        });
    }
}