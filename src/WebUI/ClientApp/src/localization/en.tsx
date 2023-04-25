const AddMenu = (result) => {
    result.sidebar_menu_header_home = "Home";
    result.sidebar_menu_page_home = "Home page";
    result.sidebar_menu_header_admin = "Admin";
    result.sidebar_menu_page_users = "Users";
    result.sidebar_menu_header_super_admin = "Super Admin";
    result.sidebar_menu_page_configuration = "Configuration";

    return result;
}

const AddHeaderMenu = (result) => {
    result.sidebar_header_menu_profile = "My profile";
    result.sidebar_header_menu_logout = "Sign out";

    result.sidebar_header_menu_title_notification = "Notifications";
    result.sidebar_header_menu_no_notifications = "No new notifications";

    return result;
}

const AddConfigurationPage = (result) => {
    result.configuration_page_title = "Service status";
    result.configuration_page_api_status = "API status";
    result.configuration_page_configuration = "Configuration";
    result.configuration_page_configuration_level = "Configuration level";

    return result;
}

const AddPersonalInfoPage = (result) => {
    result.personal_ingo_page_title = "User id";
    result.personal_ingo_page_account_info = "Account info";
    result.personal_ingo_page_save = "Save";
    result.personal_ingo_page_name_field = "Name";
    result.personal_ingo_page_email_field = "Email";
    result.personal_ingo_page_created_date_field = "Created date";
    result.personal_ingo_page_approve = "Approve";
    result.personal_ingo_page_account_updated_message = "User info updated";

    return result;
}

const AddLoginPage = (result) => {
    result.login_page_sign_in = "Sign in with";

    return result;
}

const AddPages = (result) => {
    result = AddLoginPage(result);

    result = AddPersonalInfoPage(result);

    result = AddConfigurationPage(result);

    return result;
}

const AddPureWords = (result) => {
    // statuses
    result.Pending = "Pending";
    result.Error = "Error";
    result.Warning = "Warning";
    result.Success = "Success";

    // health
    result.Healthy = "Healthy";
    result.Unhealthy = "Unhealthy";

    // data
    result.NoData = "No data";

    // roles
    result.role_admin = "Admin";
    result.role_super_admin = "Super Admin";
    result.role_user = "User";

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