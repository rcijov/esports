using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Group` (
    ///`idGroup` int(11) NOT NULL DEFAULT '0',
    ///`name` varchar(10) DEFAULT NULL,
    ///PRIMARY KEY(`idGroup`) USING BTREE
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Group
    {
        /// <summary>
        /// Primary key of the group
        /// </summary>
        int idGroup { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        String name { get; set; }
    }
}
