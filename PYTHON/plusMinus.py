def plusMinus(arr):
    total=len(arr)
    pos=0
    neg=0
    zero=0
    
    for num in arr:
     if num>0:
       pos +=1
     elif num<0:
       neg +=1
     else:
       zero +=1
       
    print(f"{pos/total:.6f}")
    print(f"{neg/total:.6f}")
    print(f"{zero/total:.6f}")
    
if __name__=='__main__':
    n=int(input())
    arr=list(map(int,input().rstrip().split()))
    plusMinus(arr)
