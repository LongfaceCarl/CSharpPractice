def main():
    peopleCount = int(input("How many people are here?\n>"))
    
    #imagine this to be some complicated code behow
    foodACount = int(input("How many A do you want?\n>"))
    foodBCount = int(input("How many B do you want?\n>"))
    #imagin this to be some complicated code above

    tempSum = (foodACount * 10 + foodBCount * 5)* 1.15
    print("You should pay {:.2f}\n".format(tempSum/peopleCount))
    return 0
def main1():
	results = ""
	total = 0
	peopleCount = int(input("How many people are here?\n>"))
	for i in range(peopleCount):
		name = input("What's your name?\n>")
		foodACount = int(input("How many A do you want?\n>"))
		foodBCount = int(input("How many B do you want?\n>"))
		tempSum = (foodACount * 10 + foodBCount * 5)* 1.15
		total += tempSum
		results += "{} should pay {:.2f}\n".format(name, tempSum)
	input("==Enter to view bill==")
	print(results)
	print("The total is:", total)
	print(total/peopleCount, "per person if AA")
	return 0

main()
main1()