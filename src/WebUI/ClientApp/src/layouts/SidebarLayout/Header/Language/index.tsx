import { connect } from "react-redux";

import useUtils from 'src/appUtils';
import LocalizationService from "src/services/LocalizationService";
import LockedSelect from 'src/components/LockedComponents/LockedSelect/LockedSelect';
import { updateLanguage } from 'src/actions/appAction';


const LanguageSwitcher = (props: any) => {
  const u = useUtils();

  const languages = LocalizationService.Languages;

  return (
    <>
      <LockedSelect
        options={languages}
        defaultKey={props.currentLanguage}
        onSelect={(option) => {
          props.updateLanguage(option.key)
          LocalizationService.UpdateLanguage(option.key);
        }} />
    </>
  );
}

const mapStateToProps = (state: any) => {
  return {
    currentLanguage: state.app.language,
  };
};

const mapDispatchToProps = (dispatch: any) => {
  return {
    updateLanguage: (payload: string) => {
      dispatch(updateLanguage(payload));
    }
  }
};

export default connect(mapStateToProps, mapDispatchToProps)(LanguageSwitcher);
