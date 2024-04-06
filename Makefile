hepsi: derle bagla calistir

derle:
	g++ -I ./include -o ./lib/main.o -c ./src/main.cpp
	g++ -I ./include -o ./lib/Sayi.o -c ./src/Sayi.cpp
	g++ -I ./include -o ./lib/Basamak.o -c ./src/Basamak.cpp


bagla: 
	g++  ./lib/main.o ./lib/Sayi.o ./lib/Basamak.o  -o ./bin/program.exe

calistir: 
	./bin/program