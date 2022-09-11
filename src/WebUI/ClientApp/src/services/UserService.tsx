import useUtils from "src/appUtils";
import Role from "src/consts/Role";
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
        if (roles) {
            if (roles.includes(Role.SuperAdmin)) {
                return Role.SuperAdmin;
            }

            if (roles.includes(Role.Admin)) {
                return Role.Admin;
            }

            if (roles.includes(Role.User)) {
                return Role.User;
            }
        }

        return Role.NoRole;
    },

    RoleToDisplay: (role: string): string => {
        const u = useUtils();

        let defaultRole = { key: Role.User, value: u.t("role_user") }
        let roleList = [
            { key: Role.SuperAdmin, value: u.t("role_super_admin") },
            { key: Role.Admin, value: u.t("role_admin") },
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
