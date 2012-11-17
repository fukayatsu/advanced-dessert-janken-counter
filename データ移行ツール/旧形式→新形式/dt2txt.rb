#exerb $

#ruby $
	#stop
#end

members = File.readlines("list.dt")
logs = File.readlines("log.dt")

File.open('log.txt','w'){|f|
	logs.each_with_index{ |log,i|


		l=log.chomp.split(/\t/s)

		jikan = Time.now.strftime("%Y/%m/%d %H:%M:%S")
		haisya = l[l.length-1]
		total = (l.length-1)*100
		sanka = l.select{|s| s != haisya}

		f.write("#{jikan},#{total},#{haisya},#{l.length-1}")
		sanka.each{|s| f.write(",#{s}")}
		f.write(",ツールによりデータ移行")
		f.puts()
	}
}

File.open('member.txt','w'){|f|
	members.each{|m|
		f.puts(m)
	}
}