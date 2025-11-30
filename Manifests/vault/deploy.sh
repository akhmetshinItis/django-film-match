#!/bin/bash

set -a
source .env
set +a

CHARTS=("backend" "frontend" "ingress" "postgres")
NAMESPACE="test1"

for CHART in "${CHARTS[@]}"; do
    helm secrets \
        --evaluate-templates \
        -b vals \
        upgrade --install \
        "$CHART" "../app/charts/$CHART" \
        -n "$NAMESPACE" --create-namespace \
        --values "../app/charts/$CHART/values.yaml"
done
