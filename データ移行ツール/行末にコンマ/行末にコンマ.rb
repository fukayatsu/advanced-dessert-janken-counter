#ruby $

logs = File.readlines("log.txt")

File.open('out_log.txt','w'){|f|
	logs.each{|log|
		f.puts("#{log.chomp},")
	}
}