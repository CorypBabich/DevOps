FROM node:12
WORKDIR /Devop_DiceRoller/bin/Debug/net8.0-windows
COPY Devop_DiceRoller.exe ./
RUN npm install
COPY . .
ENV PORT=8080
EXPOSE 8080
CMD ["npm","start"]