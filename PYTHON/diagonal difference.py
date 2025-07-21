def diagonalDifference(arr):
    n = len(arr)
    left_to_right = 0
    right_to_left = 0

    for i in range(n):
        left_to_right += arr[i][i]
        right_to_left += arr[i][n - 1 - i]

    return abs(left_to_right - right_to_left)

# Read input
n = int(input())
arr = []

for _ in range(n):
    row = list(map(int, input().rstrip().split()))
    arr.append(row)

result = diagonalDifference(arr)
print(result)
