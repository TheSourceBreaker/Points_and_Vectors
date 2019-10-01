using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points_and_Vectors
{
    
    struct Vector2
    {
        float x, y;
        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }
    }
    struct Vector3
    {
        float x, y, z;
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        //public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        //{
        //    return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        //}

        //public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        //{
        //    return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        //}

        
    }}
