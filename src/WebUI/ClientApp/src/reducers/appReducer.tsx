const appReducer = (state = {
  language: "EN"
}, action: any) => {
  switch (action.type) {
    case "UPDATE_LANGUAGE":
      if (state.language != action.payload) {
        state = {
          ...state,
          language: action.payload
        };
      }
      break;
    default:
      break;
  }
  return state;
};

export default appReducer;
