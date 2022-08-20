import i18next from "i18next";


const LocalizationService = {
    Languages: [
        { key: "en", value: "EN" },
        { key: "ru", value: "RU" },
    ],
    UpdateLanguage: (languageCode) => {
        i18next.changeLanguage(languageCode)
    },
    GetCurrentLanguage: () => {
        return i18next.language;
    },
}

export default LocalizationService;
