import {
    Button,
    styled,
} from '@mui/material';

import CustomButtonProps from '../Interface';


const RedButton = styled(Button)(
    ({ theme }) => `
       background: ${theme.colors.error.main};
       color: ${theme.palette.error.contrastText};
  
       &:hover {
          background: ${theme.colors.error.dark};
       }
      `
);

const ButtonError = ({ text, ...props }: CustomButtonProps) => {
    props.variant = "contained"

    return (
        <RedButton {...props}>
            {text}
        </RedButton>
    );
}

export default (ButtonError);
