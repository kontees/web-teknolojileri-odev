hepsi: derle bagla calistir

derle:
	g++ -I ./include -o ./lib/main.o -c ./src/main.cpp
	g++ -I ./include -o ./lib/AVLTree.o -c ./src/AVLTree.cpp
	g++ -I ./include -o ./lib/stack.o -c ./src/stack.cpp

bagla:
	g++ ./lib/main.o ./lib/AVLTree.o ./lib/stack.o -o ./bin/program.exe

calistir:
	./bin/program

