import { toast } from "react-toastify";
import translate from "translate";

import LocalizationService from "src/services/LocalizationService";


const ErrorToast = async (message: string) => {
    const language = LocalizationService.GetCurrentLanguage();

    if (language != "en") {
        message = await translate(message, language);
    }

    return toast.error(message, {
        position: "top-right",
        autoClose: 5000,
        hideProgressBar: false,
        closeOnClick: true,
        pauseOnHover: true,
        draggable: true,
        progress: undefined,
    });
}


export default ErrorToast;

