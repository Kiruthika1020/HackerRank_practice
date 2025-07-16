def compareTriplets(a, b):
    alice_points = 0
    bob_points = 0

    for i in range(3):
        if a[i] > b[i]:
            alice_points += 1
        elif a[i] < b[i]:
            bob_points += 1

    return [alice_points, bob_points]

a = list(map(int, input().strip().split()))
b = list(map(int, input().strip().split()))
result = compareTriplets(a, b)
print(*result)