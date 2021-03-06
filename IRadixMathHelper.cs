using System;
using System.Text;
//using System.Numerics;

namespace PeterO {
  interface IRadixMathHelper<T> {
    int GetRadix();
    int GetArithmeticSupport();
    int GetSign(T value);
    int GetFlags(T value);
    BigInteger GetMantissa(T value);
    BigInteger GetExponent(T value);
    BigInteger RescaleByExponentDiff(BigInteger value, BigInteger exp1, BigInteger exp2);
    T ValueOf(int val);
    T CreateNewWithFlags(BigInteger mantissa, BigInteger exponent, int flags);
    IShiftAccumulator CreateShiftAccumulatorWithDigits(BigInteger value, int lastDigit, int olderDigits);
    IShiftAccumulator CreateShiftAccumulator(BigInteger value);
    bool HasTerminatingRadixExpansion(BigInteger num, BigInteger den);
    BigInteger MultiplyByRadixPower(BigInteger value, FastInteger power);
  }
}
