import {
    Box,
    Typography,
    Card,
    Grid,
    List,
} from '@mui/material';

import HealthCheck from './HealthCheck';
import Configuration from './Configuration';
import useUtils from 'src/appUtils';

const Home = (props: any) => {
    const u = useUtils()

    return (
        <Grid sx={{ p: "5%" }}>
            <Box pb={2}>
                <Typography variant="h2">{u.t("configuration_page_title")}</Typography>
            </Box>
            <Card>
                <List>
                    <HealthCheck />
                </List>
            </Card>

            <Card sx={{ mt: 2 }}>
                <List>
                    <Configuration />
                </List>
            </Card>
        </Grid>
    );
}

export default (Home);
