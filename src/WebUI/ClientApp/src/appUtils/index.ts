import { useTheme } from "@mui/material";
import { useTranslation } from "react-i18next";
import { useLocation, useNavigate } from "react-router-dom";


const useUtils = () => {

    const navigate = useNavigate();
    const { state } = useLocation();
    const { t } = useTranslation()
    const theme = useTheme();

    return {
        react: {
            navigate: navigate,
            locationState: state,
            theme: theme,
        },
        t: (key: string) => t(key),
        log: (value) => {
            console.log(value)
        },
    }
}

export default useUtils
