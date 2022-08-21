const AddMenu = (result) => {
    result.sidebar_menu_header_home = "Основное";
    result.sidebar_menu_page_home = "Основная";
    result.sidebar_menu_header_admin = "Админская";
    result.sidebar_menu_page_users = "Пользователи";
    result.sidebar_menu_header_super_admin = "Супер Админская";
    result.sidebar_menu_page_configuration = "Конфигурация";

    return result;
}

const AddHeaderMenu = (result) => {
    result.sidebar_header_menu_profile = "Мой профиль";
    result.sidebar_header_menu_logout = "Выйти";

    result.sidebar_header_menu_title_notification = "Уведомления";
    result.sidebar_header_menu_no_notifications = "Нет новых уведомлений";

    return result;
}

const AddConfigurationPage = (result) => {
    result.configuration_page_title = "Статус сервиса";
    result.configuration_page_api_status = "статус API";
    result.configuration_page_configuration = "Конфигурация";
    result.configuration_page_configuration_level = "Уровень конфигурации";

    return result;
}

const AddLoginPage = (result) => {
    result.login_page_sign_in = "Войти через";

    return result;
}

const AddPages = (result) => {
    result = AddLoginPage(result);

    result = AddConfigurationPage(result);

    return result;
}

const AddPureWords = (result) => {
    // statuses
    result.Pending = "Ожидание";
    result.Error = "Ошибка";
    result.Warning = "Предупреждение";
    result.Success = "Успех";

    // health
    result.Healthy = "Здоров";
    result.Unhealthy = "Не здоров";

    // data
    result.NoData = "Нет данных";

    // roles
    result.role_admin = "Админ";
    result.role_super_admin = "Супер Админ";
    result.role_user = "Пользователь";

    return result;
}

const en = () => {
    let result = {};

    result = AddMenu(result);

    result = AddHeaderMenu(result);

    result = AddPages(result);

    result = AddPureWords(result);

    return result;
}

export default en();