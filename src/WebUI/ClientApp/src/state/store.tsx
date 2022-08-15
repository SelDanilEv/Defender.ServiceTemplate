import { legacy_createStore, combineReducers, applyMiddleware } from "redux";
import { createLogger } from "redux-logger";
import thunk from "redux-thunk";

import stateLoader from "./StateLoader";

import auth from "src/reducers/authReducer";
import loading from "src/reducers/loadingReducer";
import app from "src/reducers/appReducer";

export default legacy_createStore(
    combineReducers(
        {
            auth,
            loading,
            app,
        }),
    stateLoader.loadState(),
    applyMiddleware(
        createLogger(),
        //comment for production
        thunk),
);
