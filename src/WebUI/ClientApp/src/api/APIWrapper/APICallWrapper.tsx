import APICallProps from "./interfaces/APICallProps"

import store from "src/state/store"
import LoadingStateService from "src/services/LoadingStateService"
import ErrorToast from "src/components/Toast/DefaultErrorToast";
import SuccessToast from 'src/components/Toast/DefaultSuccessToast';


const APICallWrapper = async (
    {
        url,
        options,
        onSuccess = async (response) => { },
        onFailure = async (response) => { },
        onFinal = async () => { },
        showSuccess = false,
        successMesage = 'Success',
        showError = true,
    }: APICallProps
) => {

    try {
        LoadingStateService.StartLoading()

        if (!options.headers) {
            options.headers = {};
        }

        let auth = store.getState().auth;

        if (auth.isAuthenticated) {
            options.headers["Authorization"] = `Bearer ${auth.token}`;
        }

        options.headers["Content-Type"] = "application/json";

        const response = await fetch(url, options);

        switch (response.status) {
            case 200:
                onSuccess(response)

                if (showSuccess) {
                    SuccessToast(successMesage)
                }
                return
            case 401:
                onFailure(response)
                break;
            default:
                onFailure(response)

                if (showError) {
                    let error = await response.json();
                    ErrorToast(error.detail);
                    break;
                }
        }

    } catch (error) {
        await onFailure(error)
        ErrorToast(error);
    } finally {
        await onFinal();
        LoadingStateService.FinishLoading()
    }
};


export default APICallWrapper;
