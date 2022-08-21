import useUtils from "src/appUtils";
import { UserInfo } from "src/models/user_info";


const UserService = {
    FromAuthUserToUser: (authUser: UserInfo) => {
        return {
            id: authUser.id,
            name: authUser.name,
            email: authUser.email,
            avatar: '/',
            role: UserService.GetHighestRole(authUser.roles),
            createdDate: authUser.createdDate
        }
    },

    GetHighestRole: (roles: string[]): string => {
        let defaultRole = { key: "User", value: "User" }
        let roleList = [
            { key: "SuperAdmin", value: "Super Admin" },
            { key: "Admin", value: "Admin" },
            defaultRole];

        for (
            let i = 0, role = {} as { key: string, value: string };
            i < roleList.length && roles;
            role = roleList[i++]) {
            if (roles.includes(role.key)) {
                return role.value;
            }
        }

        return defaultRole.value;
    },

    LocalizeRole: (role: string): string => {
        const u = useUtils();

        let defaultRole = { key: "User", value: u.t("role_user") }
        let roleList = [
            { key: "Super Admin", value: u.t("role_super_admin") },
            { key: "Admin", value: u.t("role_admin") },
            defaultRole];

        for (
            let i = 0, localizedRole = {} as { key: string, value: string };
            i < roleList.length && role;
            localizedRole = roleList[i++]) {
            if (role == localizedRole.key) {
                return localizedRole.value;
            }
        }

        return defaultRole.value;
    }
}

export default UserService;
