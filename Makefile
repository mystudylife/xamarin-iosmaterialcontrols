all:
	$(MAKE) -C library
	cp library/iOSUILib.a binding/iOSUILib.a
	$(MAKE) -C binding

clean:
	$(MAKE) -C library clean
	$(MAKE) -C binding clean