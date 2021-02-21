CREATE TABLE db_version
(
    id uuid primary key not null,
    db_version text not null,
    install_date timestamp not null,
    notes text
);

CREATE TABLE IF NOT EXISTS weather_forecast
(
    id uuid primary key,
    forecast_time timestamp,
    temp_c numeric,
    temp_f numeric generated always as (32 + (temp_c * 0.05556)) stored,
    summary text
);

insert into db_version (id, db_version, install_date, notes) values ('0d3cb499-3976-44b1-9e84-b30e13bf90a4', '0.1', CURRENT_TIMESTAMP, 'n/a');