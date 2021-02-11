using System;

namespace Project_Alpha.Source
{
    [Serializable]
    public struct Vector : IEquatable<Vector>
    {
        //Constructors
        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //Private

        //Public
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        //Getter
        public (float, float, float) Deconstruct() => (X, Y, Z);

        //Operators
        public static Vector operator +(Vector A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = A.X + B.X;
            vec.Y = A.Y + B.Y;
            vec.Z = A.Z + B.Z;
            return vec;
        }
        public static Vector operator -(Vector A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = A.X - B.X;
            vec.Y = A.Y - B.Y;
            vec.Y = A.Z - B.Z;
            return vec;
        }
        public static Vector operator *(Vector A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = A.X * B.X;
            vec.Y = A.Y * B.Y;
            vec.Z = A.Z * B.Z;
            return vec;
        }
        public static Vector operator /(Vector A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = A.X / B.X;
            vec.Y = A.Y / B.Y;
            vec.Z = A.Z / B.Z;
            return vec;
        }

        //Float operators
        public static Vector operator *(Vector A, float B)
        {
            Vector vec = new Vector();
            vec.X = A.X * B;
            vec.Y = A.Y * B;
            vec.Z = A.Z * B;
            return vec;
        }
        public static Vector operator *(float A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = B.X * A;
            vec.Y = B.Y * A;
            vec.Z = B.Z * A;
            return vec;
        }

        public static Vector operator /(float A, Vector B)
        {
            Vector vec = new Vector();
            vec.X = A / B.X;
            vec.Y = A / B.Y;
            vec.Z = A / B.Z;
            return vec;
        }
        public static Vector operator /(Vector A, float B)
        {
            Vector vec = new Vector();
            vec.X = A.X / B;
            vec.Y = A.Y / B;
            vec.Z = A.Z / B;
            return vec;
        }

        public static bool operator ==(Vector A, Vector B) => MathF.Abs(A.X - B.X) < 0.0001f && MathF.Abs(A.Y - B.Y) < 0.0001f && MathF.Abs(A.Z - B.Z) < 0.0001f;

        public static bool operator !=(Vector A, Vector B) => !((A.X == B.X) && (A.Y == B.Y) && (A.Z == B.Z));

        //Requirements for overloads
        public override bool Equals(object o) => o is Vector && Equals(o);
        public override int GetHashCode() { return HashCode.Combine(X, Y, Z); }
        public override string ToString() => $"X: {X}, Y: {Y}, Z: {Z}";

        //Other things
        public bool Equals(Vector Other) => this == Other;

        //Cross product
        public Vector Cross(Vector a, Vector b)
        {
            float x, y, z;
            x = a.Y * b.Y - a.Z * b.Y;
            y = a.Z * b.X - a.X * a.Z;
            z = a.X * b.Y - a.Y * b.X;
            return new Vector(x, y, z);
        }

        //Lerp
        public static Vector Lerp(Vector a, Vector b, double t = 1)
        {
            float X = (float)Math.Lerp(a.X, b.X, t);
            float Y = (float)Math.Lerp(a.Y, b.Y, t);
            float Z = (float)Math.Lerp(a.Z, b.Z, t);
            return new Vector(X, Y, Z);
        }

        //Normalize setup
        public static float Dist(Vector a, Vector b) => MathF.Sqrt (
              (a.X - b.X) * (a.X - b.X)
            + (a.Y - b.Y) * (a.Y - b.Y)
            + (a.Z - b.Z) * (a.Z - b.Z)
            );

        public static float SqrMagnitude(Vector vec) => vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z;

        public static float Magnitude(Vector vec) => MathF.Sqrt(SqrMagnitude(vec));

        public static Vector Normalize(Vector vec) => vec / Magnitude(vec);
    }
}
