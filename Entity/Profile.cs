using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkBuddies.Entity
{
    /// <summary>
    /// CREATE TABLE `Profile` (
    ///`rating` varchar(10) DEFAULT NULL,
    ///`personality` varchar(10) DEFAULT NULL,
    ///`typeDrinker` varchar(10) DEFAULT NULL,
    ///`description` varchar(120) DEFAULT NULL,
    ///`image` varchar(10) DEFAULT NULL,
    ///`idProfile` int(11) NOT NULL AUTO_INCREMENT,
    ///PRIMARY KEY(`idProfile`) USING BTREE
    ///) ENGINE=InnoDB DEFAULT CHARSET=latin1;
    /// </summary>
    class Profile
    {
        /// <summary>
        /// User rating
        /// </summary>
        String rating { get; set; }

        /// <summary>
        /// Type of user personality
        /// </summary>
        String personality { get; set; }

        /// <summary>
        /// Type of drinker
        /// </summary>
        String typeDrinker { get; set; }

        /// <summary>
        /// User description
        /// </summary>
        String description { get; set; }

        /// <summary>
        /// User image
        /// </summary>
        String image { get; set; }

        /// <summary>
        /// Primary key for profile id
        /// </summary>
        int idProfile { get; set; }
    }
}
