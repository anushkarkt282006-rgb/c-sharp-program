Write a program to display maximum numbermfrom inputed 5 numbers
numbers = []
for i in range(5):
    num = int(input(f"Enter number {i+1}: "))
    numbers.append(num)

max_number = max(numbers)
print(f"Maximum number: {max_number}")