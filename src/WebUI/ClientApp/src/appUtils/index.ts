import { useTheme } from "@mui/material";
import { useTranslation } from "react-i18next";
import { useNavigate } from "react-router-dom";

const useUtils = () => {

    const navigate = useNavigate();
    const { t } = useTranslation()
    const theme = useTheme();

    return {
        react: {
            navigate: navigate,
            theme: theme,
        },
        t: (key: string) => t(key),
        log: (value) => {
            console.log(value)
        },
    }
}

export default useUtils