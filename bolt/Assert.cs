using System;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x0200003C RID: 60
[Token(Token = "0x200003C")]
internal static class Assert
{
	// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x79EDF0", Offset = "0x79D3F0", VA = "0x18079EDF0")]
	[Conditional("DEBUG")]
	internal static void Fail()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x79EE30", Offset = "0x79D430", VA = "0x18079EE30")]
	[Conditional("DEBUG")]
	internal static void Fail(string message)
	{
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Same(object a, object b)
	{
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Same(object a, object b, string error)
	{
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000252")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void NotSame(object a, object b)
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000253")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Null(object a)
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000254")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Null(object a, string msg)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void NotNull(object a)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void Equal(object a, object b)
	{
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000257")]
	[Conditional("DEBUG")]
	internal static void Equal<T>(T a, T b) where T : IEquatable<T>
	{
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Conditional("DEBUG")]
	internal static void NotEqual(object a, object b)
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000259")]
	[Conditional("DEBUG")]
	internal static void NotEqual<T>(T a, T b) where T : IEquatable<T>
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x79EE80", Offset = "0x79D480", VA = "0x18079EE80")]
	[Conditional("DEBUG")]
	internal static void True(bool condition)
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x79EED0", Offset = "0x79D4D0", VA = "0x18079EED0")]
	[Conditional("DEBUG")]
	internal static void False(bool condition)
	{
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025C")]
	[Address(RVA = "0x79EF20", Offset = "0x79D520", VA = "0x18079EF20")]
	[Conditional("DEBUG")]
	internal static void False(bool condition, string message)
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025D")]
	[Address(RVA = "0x79EF80", Offset = "0x79D580", VA = "0x18079EF80")]
	[Conditional("DEBUG")]
	internal static void True(bool condition, string message)
	{
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x79EFE0", Offset = "0x79D5E0", VA = "0x18079EFE0")]
	[Conditional("DEBUG")]
	internal static void True(bool condition, string message, params object[] args)
	{
	}
}
