FROM node:16-alpine as builder
# Set the working directory to /app inside the container
WORKDIR /usr/src/app/my-app
EXPOSE 3000:3000

COPY ./package*.json .

ENV PATH /usr/src/app/my-app/node_modules/.bin:$PATH

RUN npm install

CMD ["npm", "start"]